# Fact f1048d76

Store id: 4616a470-e7c7-484b-a94f-4df9be5bd980

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
- posted_at: `2026-11-09T23:44:49.4939750+00:00`

## Data

```json
{
  "end_line": 990,
  "entity_kind": "method",
  "parent": "OuterRef",
  "start_line": 987,
  "symbol": "OuterRef.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":987,"selector":"L987-L990","symbol":"OuterRef.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OuterRef.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 990,
    "entity_kind": "method",
    "parent": "OuterRef",
    "start_line": 987,
    "symbol": "OuterRef.resolve_expression"
  },
  "id": "4616a470-e7c7-484b-a94f-4df9be5bd980",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4939750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 987,
        "selector": "L987-L990",
        "symbol": "OuterRef.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2815c55d-b1e4-4c3b-9264-fd5765b51238",
  "subject_name": "django/db/models/expressions::OuterRef.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
