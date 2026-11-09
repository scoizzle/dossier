# Fact 825690df

Store id: 2cbdfc68-f06e-4f37-91ec-4a8a0d5d4319

## Text

```text
contains class YearGte
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
  - target: [django/db/models/lookups::YearGte](../../django-db-models-lookups-yeargte/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":766,"symbol":"YearGte"}`

## Referenced by

None.

## Subject

[django/db/models/lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "2cbdfc68-f06e-4f37-91ec-4a8a0d5d4319",
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
        "line": 766,
        "symbol": "YearGte"
      },
      "rel": "contains",
      "target": "5916596f-8f1b-4cfd-a6cf-99e7e0acbc48"
    }
  ],
  "status": "live",
  "subject_id": "08d59620-584d-4fa4-9163-3befcd8a2879",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class YearGte"
}
```
