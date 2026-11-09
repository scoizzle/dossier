# Fact ff5dcfaa

Store id: 0dcb7cb5-3f05-4e6e-9608-a879c5ab1d1d

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
- posted_at: `2026-11-09T23:44:58.5625490+00:00`

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
  "id": "0dcb7cb5-3f05-4e6e-9608-a879c5ab1d1d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.5625490+00:00"
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
  "subject_id": "326c9f2c-3dac-4349-8d8e-027fa159f850",
  "subject_name": "django/db/models/sql/query::RawQuery.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
