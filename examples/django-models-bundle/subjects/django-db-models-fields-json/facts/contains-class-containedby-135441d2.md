# Fact 135441d2

Store id: 882b3770-d9de-4bdb-8730-2ed12bd22516

## Text

```text
contains class ContainedBy
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
- posted_at: `2026-11-09T22:39:43.7741560+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/json::ContainedBy](../../django-db-models-fields-json-containedby/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"symbol":"ContainedBy"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "882b3770-d9de-4bdb-8730-2ed12bd22516",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7741560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 168,
        "symbol": "ContainedBy"
      },
      "rel": "contains",
      "target": "fde0668b-1d20-46a1-bce0-34f38c7c4a5f"
    }
  ],
  "status": "live",
  "subject_id": "e8033e5a-9cc0-487a-86e5-7f58586f9b90",
  "subject_name": "django/db/models/fields/json",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ContainedBy"
}
```
