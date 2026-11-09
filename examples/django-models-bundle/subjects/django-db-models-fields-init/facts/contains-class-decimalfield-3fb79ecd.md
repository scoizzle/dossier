# Fact 3fb79ecd

Store id: 7fa169ae-6388-4b53-842a-351f2e29ce48

## Text

```text
contains class DecimalField
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
  - target: [django/db/models/fields/__init__::DecimalField](../../django-db-models-fields-init-decimalfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":1740,"symbol":"DecimalField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "7fa169ae-6388-4b53-842a-351f2e29ce48",
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
        "line": 1740,
        "symbol": "DecimalField"
      },
      "rel": "contains",
      "target": "2405b5de-548f-4174-84de-c66e6d3c1486"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class DecimalField"
}
```
