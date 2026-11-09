# Fact 8311f0d5

Store id: 350971c0-61f6-488f-8eb8-963db048b27a

## Text

```text
contains class URLField
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
  - target: [django/db/models/fields/__init__::URLField](../../django-db-models-fields-init-urlfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2719,"symbol":"URLField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "350971c0-61f6-488f-8eb8-963db048b27a",
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
        "line": 2719,
        "symbol": "URLField"
      },
      "rel": "contains",
      "target": "fb1f2233-938e-446d-937b-90f1b5cd7237"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class URLField"
}
```
