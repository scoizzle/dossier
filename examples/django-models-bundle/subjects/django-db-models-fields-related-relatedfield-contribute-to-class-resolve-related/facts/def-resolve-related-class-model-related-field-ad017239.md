# Fact ad017239

Store id: 45311ae1-176d-41fc-85fe-11a0bef9fc64

## Text

```text
def resolve_related_class(model, related, field)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.2662420+00:00`

## Data

```json
{
  "end_line": 403,
  "entity_kind": "function",
  "parent": "RelatedField.contribute_to_class",
  "start_line": 401,
  "symbol": "RelatedField.contribute_to_class.resolve_related_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":401,"selector":"L401-L403","symbol":"RelatedField.contribute_to_class.resolve_related_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.contribute_to_class.resolve_related_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 403,
    "entity_kind": "function",
    "parent": "RelatedField.contribute_to_class",
    "start_line": 401,
    "symbol": "RelatedField.contribute_to_class.resolve_related_class"
  },
  "id": "45311ae1-176d-41fc-85fe-11a0bef9fc64",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2662420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 401,
        "selector": "L401-L403",
        "symbol": "RelatedField.contribute_to_class.resolve_related_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "9e94532e-b350-4cc6-b566-54ba0e45e2bd",
  "subject_name": "django/db/models/fields/related::RelatedField.contribute_to_class.resolve_related_class",
  "tags": [
    "entity:function"
  ],
  "text": "def resolve_related_class(model, related, field)"
}
```
