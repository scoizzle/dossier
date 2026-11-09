# Fact 86c395f9

Store id: 30a739d5-d3ba-4eac-8fee-f9648cab2d0e

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
- posted_at: `2026-11-09T22:39:48.3048640+00:00`

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
  "id": "30a739d5-d3ba-4eac-8fee-f9648cab2d0e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.3048640+00:00"
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
      "target": "c16794c3-7902-446b-bd5e-7ff620c081e5"
    }
  ],
  "status": "live",
  "subject_id": "8a4b2e84-bc75-4dfe-afa5-aa8af215b8c6",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Regex"
}
```
