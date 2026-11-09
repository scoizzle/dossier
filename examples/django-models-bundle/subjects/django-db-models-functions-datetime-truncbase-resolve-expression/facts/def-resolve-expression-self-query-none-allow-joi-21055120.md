# Fact 21055120

Store id: 878d8aab-a8fe-41b8-93ea-e225dd8d9e21

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
- posted_at: `2026-11-09T23:32:01.2609740+00:00`

## Data

```json
{
  "end_line": 342,
  "entity_kind": "method",
  "parent": "TruncBase",
  "start_line": 283,
  "symbol": "TruncBase.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":283,"selector":"L283-L342","symbol":"TruncBase.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncBase.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 342,
    "entity_kind": "method",
    "parent": "TruncBase",
    "start_line": 283,
    "symbol": "TruncBase.resolve_expression"
  },
  "id": "878d8aab-a8fe-41b8-93ea-e225dd8d9e21",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2609740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 283,
        "selector": "L283-L342",
        "symbol": "TruncBase.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "ef469e43-ac37-4fa1-bd9c-73f6a9942549",
  "subject_name": "django/db/models/functions/datetime::TruncBase.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
