# Fact 2cca913c

Store id: b14c378a-a302-46df-b437-bb7f5bbf7c28

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
- posted_at: `2026-11-09T23:44:49.4909820+00:00`

## Data

```json
{
  "end_line": 974,
  "entity_kind": "method",
  "parent": "ResolvedOuterRef",
  "start_line": 963,
  "symbol": "ResolvedOuterRef.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":963,"selector":"L963-L974","symbol":"ResolvedOuterRef.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ResolvedOuterRef.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 974,
    "entity_kind": "method",
    "parent": "ResolvedOuterRef",
    "start_line": 963,
    "symbol": "ResolvedOuterRef.resolve_expression"
  },
  "id": "b14c378a-a302-46df-b437-bb7f5bbf7c28",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4909820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 963,
        "selector": "L963-L974",
        "symbol": "ResolvedOuterRef.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3b5ce9ca-1226-4f11-9cda-34d4595f9ef7",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
