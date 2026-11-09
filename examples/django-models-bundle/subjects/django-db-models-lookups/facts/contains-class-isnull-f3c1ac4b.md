# Fact f3c1ac4b

Store id: 671aefd5-7150-4ea8-8bf3-9d1211a23c23

## Text

```text
contains class IsNull
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
- posted_at: `2026-11-09T23:44:55.1315130+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/lookups::IsNull](../../django-db-models-lookups-isnull/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":665,"symbol":"IsNull"}`

## Referenced by

None.

## Subject

[django/db/models/lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "671aefd5-7150-4ea8-8bf3-9d1211a23c23",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.1315130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 665,
        "symbol": "IsNull"
      },
      "rel": "contains",
      "target": "92bb073f-68be-4ddc-8548-f04e05999ada"
    }
  ],
  "status": "live",
  "subject_id": "08d59620-584d-4fa4-9163-3befcd8a2879",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class IsNull"
}
```
