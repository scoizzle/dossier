# Fact 378d44eb

Store id: 29ecf7db-50fd-45a6-8b47-9ca0a826a61b

## Text

```text
def resolve_expression(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:40.0442660+00:00`

## Data

```json
{
  "end_line": 325,
  "entity_kind": "method",
  "parent": "Count",
  "start_line": 311,
  "symbol": "Count.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":311,"selector":"L311-L325","symbol":"Count.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Count.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 325,
    "entity_kind": "method",
    "parent": "Count",
    "start_line": 311,
    "symbol": "Count.resolve_expression"
  },
  "id": "29ecf7db-50fd-45a6-8b47-9ca0a826a61b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0442660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 311,
        "selector": "L311-L325",
        "symbol": "Count.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "3eb5eb76-fef8-4dfe-b34e-541d5d8280ff",
  "subject_name": "django/db/models/aggregates::Count.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
