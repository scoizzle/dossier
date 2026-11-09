# Fact 14a5bd05

Store id: 16384716-397c-4ee0-b892-a6c10ebbb486

## Text

```text
contains function resolve_callables
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
- posted_at: `2026-11-09T23:45:00.0778950+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/utils::resolve_callables](../../django-db-models-utils-resolve-callables/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":28,"symbol":"resolve_callables"}`

## Referenced by

None.

## Subject

[django/db/models/utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "16384716-397c-4ee0-b892-a6c10ebbb486",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0778950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 28,
        "symbol": "resolve_callables"
      },
      "rel": "contains",
      "target": "4f4f83dd-c45c-4b2d-9fa2-57b90d550e62"
    }
  ],
  "status": "live",
  "subject_id": "3a2f8b91-5e76-4523-aac0-4f1c8c9f9145",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function resolve_callables"
}
```
