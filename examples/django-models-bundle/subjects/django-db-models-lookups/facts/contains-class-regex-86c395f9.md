# Fact 86c395f9

Store id: 82d31d3f-f05a-4b2d-80d8-7d173e4698bb

## Text

```text
contains class Regex
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
- posted_at: `2026-11-09T23:32:03.5009330+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/lookups::Regex](../../django-db-models-lookups-regex/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":691,"symbol":"Regex"}`

## Referenced by

None.

## Subject

[django/db/models/lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "82d31d3f-f05a-4b2d-80d8-7d173e4698bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.5009330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 691,
        "symbol": "Regex"
      },
      "rel": "contains",
      "target": "28b6e423-5828-4cef-813c-7d0f1be1e214"
    }
  ],
  "status": "live",
  "subject_id": "e7bf7849-709d-446b-ad7a-17abee6ffd25",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Regex"
}
```
