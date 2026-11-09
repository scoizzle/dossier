# Fact 591cfe9f

Store id: 48ba95d4-e975-4357-84ee-bd68060ee75c

## Text

```text
contains class Pi
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
- posted_at: `2026-11-09T23:44:53.7795160+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/functions/math::Pi](../../django-db-models-functions-math-pi/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":131,"symbol":"Pi"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "48ba95d4-e975-4357-84ee-bd68060ee75c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7795160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 131,
        "symbol": "Pi"
      },
      "rel": "contains",
      "target": "cca98509-69d3-4dab-b7b6-95625d7a4445"
    }
  ],
  "status": "live",
  "subject_id": "a574d944-89dc-455a-aff8-c3b908ba3f8a",
  "subject_name": "django/db/models/functions/math",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Pi"
}
```
