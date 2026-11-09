# Fact ff5dcfaa

Store id: e3a89ba5-545f-40ce-aaad-5d4f96b8f4f5

## Text

```text
def __repr__(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.2039450+00:00`

## Data

```json
{
  "end_line": 195,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 194,
  "symbol": "RawQuery.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":194,"selector":"L194-L195","symbol":"RawQuery.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 195,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 194,
    "symbol": "RawQuery.__repr__"
  },
  "id": "e3a89ba5-545f-40ce-aaad-5d4f96b8f4f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2039450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 194,
        "selector": "L194-L195",
        "symbol": "RawQuery.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d5c9f4f7-7a96-4cd8-acb5-31080b8e51a7",
  "subject_name": "django/db/models/sql/query::RawQuery.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
