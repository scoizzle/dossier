# Fact e4d96a29

Store id: 6c59db22-8ee1-439d-950f-b6cc5dfc64ac

## Text

```text
contains function resolve_relation
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
- posted_at: `2026-11-09T23:31:58.9119250+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/related::resolve_relation](../../django-db-models-fields-related-resolve-relation/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":52,"symbol":"resolve_relation"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "6c59db22-8ee1-439d-950f-b6cc5dfc64ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.9119250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 52,
        "symbol": "resolve_relation"
      },
      "rel": "contains",
      "target": "da644160-17e5-4365-8690-70389c43ca34"
    }
  ],
  "status": "live",
  "subject_id": "2dd9aa9c-962a-42d5-9466-04fc4602083a",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:function"
  ],
  "text": "contains function resolve_relation"
}
```
