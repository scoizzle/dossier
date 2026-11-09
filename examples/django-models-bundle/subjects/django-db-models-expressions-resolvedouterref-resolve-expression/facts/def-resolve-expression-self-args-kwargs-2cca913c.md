# Fact 2cca913c

Store id: 82749abb-b805-42bb-b9d4-cb5c30afc794

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
- posted_at: `2026-11-09T22:39:41.5687970+00:00`

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
  "id": "82749abb-b805-42bb-b9d4-cb5c30afc794",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5687970+00:00"
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
  "subject_id": "06065a52-5efd-4ff0-8a25-de803cdea0b9",
  "subject_name": "django/db/models/expressions::ResolvedOuterRef.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
