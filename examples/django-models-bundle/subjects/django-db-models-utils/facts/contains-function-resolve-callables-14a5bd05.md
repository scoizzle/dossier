# Fact 14a5bd05

Store id: e0a4edbe-f150-4c9a-8706-f290b2e63ea4

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
- posted_at: `2026-11-09T22:39:52.1602360+00:00`

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
  "id": "e0a4edbe-f150-4c9a-8706-f290b2e63ea4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:52.1602360+00:00"
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
      "target": "b092c6e7-9b1f-4f62-b617-70455d30146f"
    }
  ],
  "status": "live",
  "subject_id": "f5e83459-87b7-40dd-8dc8-0296e557a739",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function resolve_callables"
}
```
