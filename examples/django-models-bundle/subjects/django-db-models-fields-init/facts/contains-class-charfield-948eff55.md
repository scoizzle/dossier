# Fact 948eff55

Store id: b2b78f34-ae12-4bbe-88f4-afae3f264c47

## Text

```text
contains class CharField
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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::CharField](../../django-db-models-fields-init-charfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1246,"symbol":"CharField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b2b78f34-ae12-4bbe-88f4-afae3f264c47",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3490680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 1246,
        "symbol": "CharField"
      },
      "rel": "contains",
      "target": "068e01d7-9dc4-422a-abc5-b3f168bfdd91"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class CharField"
}
```
