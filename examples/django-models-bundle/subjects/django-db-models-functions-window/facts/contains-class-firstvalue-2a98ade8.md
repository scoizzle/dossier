# Fact 2a98ade8

Store id: 42a256bf-899d-401b-940d-d64ea49191ef

## Text

```text
contains class FirstValue
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
- posted_at: `2026-11-09T23:44:54.5136690+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/functions/window::FirstValue](../../django-db-models-functions-window-firstvalue/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":31,"symbol":"FirstValue"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "42a256bf-899d-401b-940d-d64ea49191ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.5136690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 31,
        "symbol": "FirstValue"
      },
      "rel": "contains",
      "target": "fe988372-17a1-44dc-94e8-07a03cf8e564"
    }
  ],
  "status": "live",
  "subject_id": "0980d3e2-fd09-4943-88c2-8f704578a39a",
  "subject_name": "django/db/models/functions/window",
  "tags": [
    "entity:class"
  ],
  "text": "contains class FirstValue"
}
```
