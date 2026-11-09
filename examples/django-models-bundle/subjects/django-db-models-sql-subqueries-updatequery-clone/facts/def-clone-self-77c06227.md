# Fact 77c06227

Store id: b1b93cdc-bb71-4b4e-91da-6f880ea4a792

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
- posted_at: `2026-11-09T23:32:07.3777710+00:00`

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
  "id": "b1b93cdc-bb71-4b4e-91da-6f880ea4a792",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.3777710+00:00"
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
  "subject_id": "79243089-494b-47b8-a298-ace44433a80b",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.clone",
  "tags": [
    "entity:method"
  ],
  "text": "def clone(self)"
}
```
