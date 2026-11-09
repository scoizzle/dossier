# Fact 8931aacf

Store id: c3ae9c15-0ed8-41ae-a783-be06454af5e8

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
- posted_at: `2026-11-09T23:32:07.3685890+00:00`

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
  "id": "c3ae9c15-0ed8-41ae-a783-be06454af5e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.3685890+00:00"
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
  "subject_id": "1e383e2f-4fa0-410d-bd2a-1108f1e7b902",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
