# Fact 701b72704d9d85a3

Store id: 72a70b81-ab57-48bc-bc8a-86b353c0d202

## Text

```text
contains class Empty
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
  - target: [django/db/models/fields/__init__::Empty](../../django-db-models-fields-init-empty-2/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":80,"symbol":"Empty"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "72a70b81-ab57-48bc-bc8a-86b353c0d202",
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
        "line": 80,
        "symbol": "Empty"
      },
      "rel": "contains",
      "target": "73495a18-c24b-41ea-acde-7dd1fa681024"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Empty"
}
```
