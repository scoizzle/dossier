# Fact 2cca913c

Store id: 9d6ce8d0-25ac-4dc9-9a91-162c9a618d7b

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
- posted_at: `2026-11-09T23:31:55.8426910+00:00`

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
  "id": "9d6ce8d0-25ac-4dc9-9a91-162c9a618d7b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8426910+00:00"
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
  "subject_id": "036df5f1-3986-4da3-8151-45554f54a6b7",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
