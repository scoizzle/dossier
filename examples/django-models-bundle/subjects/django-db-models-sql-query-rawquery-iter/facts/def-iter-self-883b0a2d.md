# Fact 883b0a2d

Store id: 060a7050-62d0-4f6a-a36f-c1b48e325a36

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T22:39:51.1996120+00:00`

## Data

```json
{
  "end_line": 192,
  "entity_kind": "method",
  "parent": "RawQuery",
  "start_line": 182,
  "symbol": "RawQuery.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":182,"selector":"L182-L192","symbol":"RawQuery.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::RawQuery.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 192,
    "entity_kind": "method",
    "parent": "RawQuery",
    "start_line": 182,
    "symbol": "RawQuery.__iter__"
  },
  "id": "060a7050-62d0-4f6a-a36f-c1b48e325a36",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.1996120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 182,
        "selector": "L182-L192",
        "symbol": "RawQuery.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d3b075dd-51fe-44f1-9e2c-576296f4a2f7",
  "subject_name": "django/db/models/sql/query::RawQuery.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
