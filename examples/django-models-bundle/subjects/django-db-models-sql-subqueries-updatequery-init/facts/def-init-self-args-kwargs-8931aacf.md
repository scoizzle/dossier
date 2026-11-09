# Fact 8931aacf

Store id: 5c37ea24-5e3e-42ed-bfb1-c05e5d216b18

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
- posted_at: `2026-11-09T23:44:59.3770300+00:00`

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
  "id": "5c37ea24-5e3e-42ed-bfb1-c05e5d216b18",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.3770300+00:00"
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
  "subject_id": "e82ac0c2-13c9-4b93-ae54-2045aee40aeb",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
