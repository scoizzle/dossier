# Fact abe80f07

Store id: 3b461ddd-278d-4521-a3e1-d6fda5821441

## Text

```text
contains class HasKeyOrArrayIndex
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
- posted_at: `2026-11-09T23:44:51.0769520+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/json::HasKeyOrArrayIndex](../../django-db-models-fields-json-haskeyorarrayindex/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":289,"symbol":"HasKeyOrArrayIndex"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "3b461ddd-278d-4521-a3e1-d6fda5821441",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0769520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 289,
        "symbol": "HasKeyOrArrayIndex"
      },
      "rel": "contains",
      "target": "100a079d-499f-4bff-af8a-f392c449888f"
    }
  ],
  "status": "live",
  "subject_id": "fa67266b-c3d1-46c4-89d8-c39e71d018cd",
  "subject_name": "django/db/models/fields/json",
  "tags": [
    "entity:class"
  ],
  "text": "contains class HasKeyOrArrayIndex"
}
```
