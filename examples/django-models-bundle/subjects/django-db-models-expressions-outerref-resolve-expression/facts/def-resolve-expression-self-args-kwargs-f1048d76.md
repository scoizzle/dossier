# Fact f1048d76

Store id: 9453e24e-213d-479e-a6d2-7f65e56db2cd

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
- posted_at: `2026-11-09T22:39:41.5716840+00:00`

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
  "id": "9453e24e-213d-479e-a6d2-7f65e56db2cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5716840+00:00"
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
  "subject_id": "184147c2-2382-454b-ba40-8e5fd25d97be",
  "subject_name": "django/db/models/expressions::OuterRef.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
