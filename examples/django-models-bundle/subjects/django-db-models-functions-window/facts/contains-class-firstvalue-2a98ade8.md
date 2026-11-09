# Fact 2a98ade8

Store id: 2ab05512-32c8-4199-bf6f-18eb78dd48ab

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
- posted_at: `2026-11-09T23:32:02.7398280+00:00`

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
  "id": "2ab05512-32c8-4199-bf6f-18eb78dd48ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.7398280+00:00"
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
      "target": "dd3831d4-294c-4e92-98e7-cb19a939f791"
    }
  ],
  "status": "live",
  "subject_id": "dbb59911-85bd-4c94-870c-c24e475e86fd",
  "subject_name": "django/db/models/functions/window",
  "tags": [
    "entity:class"
  ],
  "text": "contains class FirstValue"
}
```
