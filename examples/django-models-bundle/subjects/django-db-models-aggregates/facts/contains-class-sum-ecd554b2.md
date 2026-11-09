# Fact ecd554b2

Store id: 14dde06b-6c0d-4170-8033-4ebc5d515484

## Text

```text
contains class Sum
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
- posted_at: `2026-11-09T22:39:40.0505810+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/aggregates::Sum](../../django-db-models-aggregates-sum/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":452,"symbol":"Sum"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "14dde06b-6c0d-4170-8033-4ebc5d515484",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0505810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 452,
        "symbol": "Sum"
      },
      "rel": "contains",
      "target": "d9972ebd-e19c-4cd8-942b-cddda683692f"
    }
  ],
  "status": "live",
  "subject_id": "d72d5420-abde-4439-aadc-c9ebfdcfd755",
  "subject_name": "django/db/models/aggregates",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Sum"
}
```
