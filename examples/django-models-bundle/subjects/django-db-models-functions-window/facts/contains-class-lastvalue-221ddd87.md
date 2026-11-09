# Fact 221ddd87

Store id: 64949aba-65de-4c57-b27c-5f974e18cc4f

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
- posted_at: `2026-11-09T22:39:47.6102730+00:00`

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
  "id": "64949aba-65de-4c57-b27c-5f974e18cc4f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.6102730+00:00"
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
      "target": "db508156-0108-405c-a1c1-de8cf235225a"
    }
  ],
  "status": "live",
  "subject_id": "c53215d3-8848-4654-aadd-1dac3d5d72de",
  "subject_name": "django/db/models/functions/window",
  "tags": [
    "entity:class"
  ],
  "text": "contains class LastValue"
}
```
