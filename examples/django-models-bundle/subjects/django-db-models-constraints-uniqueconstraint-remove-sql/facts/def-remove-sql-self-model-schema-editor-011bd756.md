# Fact 011bd756

Store id: d44f1d1b-4535-4d42-b3c8-3754b6d7ac51

## Text

```text
def remove_sql(self, model, schema_editor)
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
- posted_at: `2026-11-09T23:44:48.7887990+00:00`

## Data

```json
{
  "end_line": 516,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 501,
  "symbol": "UniqueConstraint.remove_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":501,"selector":"L501-L516","symbol":"UniqueConstraint.remove_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.remove_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 516,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 501,
    "symbol": "UniqueConstraint.remove_sql"
  },
  "id": "d44f1d1b-4535-4d42-b3c8-3754b6d7ac51",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7887990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 501,
        "selector": "L501-L516",
        "symbol": "UniqueConstraint.remove_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "efd9a241-b580-4508-b84f-4d16ece77d41",
  "subject_name": "django/db/models/constraints::UniqueConstraint.remove_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def remove_sql(self, model, schema_editor)"
}
```
