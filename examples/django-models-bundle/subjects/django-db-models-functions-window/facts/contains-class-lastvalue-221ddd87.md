# Fact 221ddd87

Store id: bbc6c6b0-9720-444f-a6b6-e602f3d5ddbd

## Text

```text
contains class LastValue
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
  - target: [django/db/models/functions/window::LastValue](../../django-db-models-functions-window-lastvalue/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":64,"symbol":"LastValue"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "bbc6c6b0-9720-444f-a6b6-e602f3d5ddbd",
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
        "line": 64,
        "symbol": "LastValue"
      },
      "rel": "contains",
      "target": "7ca460b0-669b-4c44-a6ae-eaa04bd0855d"
    }
  ],
  "status": "live",
  "subject_id": "dbb59911-85bd-4c94-870c-c24e475e86fd",
  "subject_name": "django/db/models/functions/window",
  "tags": [
    "entity:class"
  ],
  "text": "contains class LastValue"
}
```
