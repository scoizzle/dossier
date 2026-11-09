# Fact 8931aacf

Store id: a919d6e5-8fee-4770-be71-e0f96f6fb2b2

## Text

```text
def __init__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:51.7301030+00:00`

## Data

```json
{
  "end_line": 56,
  "entity_kind": "method",
  "parent": "UpdateQuery",
  "start_line": 54,
  "symbol": "UpdateQuery.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":54,"selector":"L54-L56","symbol":"UpdateQuery.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 56,
    "entity_kind": "method",
    "parent": "UpdateQuery",
    "start_line": 54,
    "symbol": "UpdateQuery.__init__"
  },
  "id": "a919d6e5-8fee-4770-be71-e0f96f6fb2b2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7301030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 54,
        "selector": "L54-L56",
        "symbol": "UpdateQuery.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "8139b5f8-e1cc-49a0-9e98-67e99a70880a",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
