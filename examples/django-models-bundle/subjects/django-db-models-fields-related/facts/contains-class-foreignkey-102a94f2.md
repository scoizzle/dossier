# Fact 102a94f2

Store id: 0d48accc-e352-484f-82ed-6605f7e5467e

## Text

```text
contains class ForeignKey
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
- posted_at: `2026-11-09T22:39:44.5223050+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/related::ForeignKey](../../django-db-models-fields-related-foreignkey/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":970,"symbol":"ForeignKey"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "0d48accc-e352-484f-82ed-6605f7e5467e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.5223050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 970,
        "symbol": "ForeignKey"
      },
      "rel": "contains",
      "target": "1046cdf0-0d3d-447a-bf51-03a24254f3aa"
    }
  ],
  "status": "live",
  "subject_id": "4e7b69d4-8947-48ba-b9c1-385f0d6a435f",
  "subject_name": "django/db/models/fields/related",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ForeignKey"
}
```
