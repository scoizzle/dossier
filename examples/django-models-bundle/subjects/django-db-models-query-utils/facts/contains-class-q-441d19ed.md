# Fact 441d19ed

Store id: 274cb259-6b5f-4d26-878b-d9affd0b561b

## Text

```text
contains class Q
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:05.2268070+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query_utils::Q](../../django-db-models-query-utils-q/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":41,"symbol":"Q"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "274cb259-6b5f-4d26-878b-d9affd0b561b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.2268070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 41,
        "symbol": "Q"
      },
      "rel": "contains",
      "target": "c902221d-bb84-4c1f-9d7a-aa5b046cb03c"
    }
  ],
  "status": "live",
  "subject_id": "c693c97c-c89e-4768-9017-bc6868b175fc",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Q"
}
```
