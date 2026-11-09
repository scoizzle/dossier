# Fact 9f22b87e

Store id: 5bfb3bdd-ba4e-40df-a3b8-dcb8b959ad74

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )
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
- posted_at: `2026-11-09T22:39:41.6208050+00:00`

## Data

```json
{
  "end_line": 1343,
  "entity_kind": "method",
  "parent": "DatabaseDefault",
  "start_line": 1327,
  "symbol": "DatabaseDefault.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1327,"selector":"L1327-L1343","symbol":"DatabaseDefault.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1343,
    "entity_kind": "method",
    "parent": "DatabaseDefault",
    "start_line": 1327,
    "symbol": "DatabaseDefault.resolve_expression"
  },
  "id": "5bfb3bdd-ba4e-40df-a3b8-dcb8b959ad74",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6208050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1327,
        "selector": "L1327-L1343",
        "symbol": "DatabaseDefault.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1c08e94d-6133-4faa-92a8-d953520f09ef",
  "subject_name": "django/db/models/expressions::DatabaseDefault.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
