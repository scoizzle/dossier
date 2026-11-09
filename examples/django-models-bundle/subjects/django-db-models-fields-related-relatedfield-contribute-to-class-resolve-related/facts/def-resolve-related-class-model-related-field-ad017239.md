# Fact ad017239

Store id: 039c788a-68f9-4b93-a26a-ea8865d93760

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
- posted_at: `2026-11-09T23:31:58.6208690+00:00`

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
  "id": "039c788a-68f9-4b93-a26a-ea8865d93760",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6208690+00:00"
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
  "subject_id": "e2b56261-ff57-4aa0-beda-51bb9a4f1b60",
  "subject_name": "django/db/models/fields/related::RelatedField.contribute_to_class.resolve_related_class",
  "tags": [
    "entity:function"
  ],
  "text": "def resolve_related_class(model, related, field)"
}
```
