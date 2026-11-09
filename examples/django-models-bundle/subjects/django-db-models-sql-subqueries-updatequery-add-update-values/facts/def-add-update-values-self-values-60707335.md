# Fact 60707335

Store id: 8958cede-4623-4b61-a28e-ae66b426603a

## Text

```text
def add_update_values(self, values)
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
- posted_at: `2026-11-09T22:39:51.7439010+00:00`

## Data

```json
{
  "end_line": 104,
  "entity_kind": "method",
  "parent": "UpdateQuery",
  "start_line": 81,
  "symbol": "UpdateQuery.add_update_values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":81,"selector":"L81-L104","symbol":"UpdateQuery.add_update_values"}`

## Items

```json
[
  {
    "text": "Convert a dictionary of field name to value mappings into an update query. This is the entry point for the public update() method on querysets.",
    "locator": {
      "line": 82
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery.add_update_values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 104,
    "entity_kind": "method",
    "parent": "UpdateQuery",
    "start_line": 81,
    "symbol": "UpdateQuery.add_update_values"
  },
  "id": "8958cede-4623-4b61-a28e-ae66b426603a",
  "items": [
    {
      "locator": {
        "line": 82
      },
      "text": "Convert a dictionary of field name to value mappings into an update query. This is the entry point for the public update() method on querysets."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7439010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 81,
        "selector": "L81-L104",
        "symbol": "UpdateQuery.add_update_values"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "2b1d2b23-4d10-4a79-81fb-1b4d75eb9ba7",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.add_update_values",
  "tags": [
    "entity:method"
  ],
  "text": "def add_update_values(self, values)"
}
```
