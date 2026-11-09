# Fact 52189e6b

Store id: 768c8332-b8a1-4af6-94f9-096a8fff11c0

## Text

```text
def create_sql(self, model, schema_editor)
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
- posted_at: `2026-11-09T23:31:54.1818320+00:00`

## Data

```json
{
  "end_line": 207,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 205,
  "symbol": "CheckConstraint.create_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":205,"selector":"L205-L207","symbol":"CheckConstraint.create_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.create_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 207,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 205,
    "symbol": "CheckConstraint.create_sql"
  },
  "id": "768c8332-b8a1-4af6-94f9-096a8fff11c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1818320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 205,
        "selector": "L205-L207",
        "symbol": "CheckConstraint.create_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "432a56d0-3d92-421a-899f-460b7fa8eb77",
  "subject_name": "django/db/models/constraints::CheckConstraint.create_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def create_sql(self, model, schema_editor)"
}
```
