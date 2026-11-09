# Fact 49645632

Store id: fab607bf-8564-4bbc-96ef-839bac220867

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
- posted_at: `2026-11-09T23:31:55.8915610+00:00`

## Data

```json
{
  "end_line": 1364,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1361,
  "symbol": "Col.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1361,"selector":"L1361-L1364","symbol":"Col.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1364,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1361,
    "symbol": "Col.__repr__"
  },
  "id": "fab607bf-8564-4bbc-96ef-839bac220867",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8915610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1361,
        "selector": "L1361-L1364",
        "symbol": "Col.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9f002be0-ab16-4ddd-9ab1-d03d85915a9f",
  "subject_name": "django/db/models/expressions::Col.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
