# Fact 8feed315

Store id: fb74c461-dbdb-4c56-99a4-9e31d31eed65

## Text

```text
def add_select_related(self, fields)
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
- posted_at: `2026-11-09T22:39:51.5030140+00:00`

## Data

```json
{
  "end_line": 2461,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2447,
  "symbol": "Query.add_select_related"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2447,"selector":"L2447-L2461","symbol":"Query.add_select_related"}`

## Items

```json
[
  {
    "text": "Set up the select_related data structure so that we only select certain related models (as opposed to all models, when self.select_related=True).",
    "locator": {
      "line": 2448
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_select_related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2461,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2447,
    "symbol": "Query.add_select_related"
  },
  "id": "fb74c461-dbdb-4c56-99a4-9e31d31eed65",
  "items": [
    {
      "locator": {
        "line": 2448
      },
      "text": "Set up the select_related data structure so that we only select certain related models (as opposed to all models, when self.select_related=True)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5030140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2447,
        "selector": "L2447-L2461",
        "symbol": "Query.add_select_related"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2c97fffe-04fd-4322-a195-dcc1a7a55578",
  "subject_name": "django/db/models/sql/query::Query.add_select_related",
  "tags": [
    "entity:method"
  ],
  "text": "def add_select_related(self, fields)"
}
```
