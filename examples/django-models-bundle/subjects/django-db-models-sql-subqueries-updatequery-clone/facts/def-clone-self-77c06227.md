# Fact 77c06227

Store id: ecf302f6-a9dd-4e39-ba7d-d80c4d497ae6

## Text

```text
def clone(self)
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
- posted_at: `2026-11-09T23:44:59.3897100+00:00`

## Data

```json
{
  "end_line": 70,
  "entity_kind": "method",
  "parent": "UpdateQuery",
  "start_line": 67,
  "symbol": "UpdateQuery.clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":67,"selector":"L67-L70","symbol":"UpdateQuery.clone"}`

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery.clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 70,
    "entity_kind": "method",
    "parent": "UpdateQuery",
    "start_line": 67,
    "symbol": "UpdateQuery.clone"
  },
  "id": "ecf302f6-a9dd-4e39-ba7d-d80c4d497ae6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.3897100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 67,
        "selector": "L67-L70",
        "symbol": "UpdateQuery.clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "0799889b-b87b-4a7a-90e7-10364c36c881",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```
