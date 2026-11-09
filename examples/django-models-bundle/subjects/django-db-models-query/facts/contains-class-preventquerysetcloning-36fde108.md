# Fact 36fde108

Store id: 0543e1c4-93cf-43bd-aaf4-5495bc39c536

## Text

```text
contains class PreventQuerySetCloning
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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query::PreventQuerySetCloning](../../django-db-models-query-preventquerysetcloning/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":342,"symbol":"PreventQuerySetCloning"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "0543e1c4-93cf-43bd-aaf4-5495bc39c536",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3472900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 342,
        "symbol": "PreventQuerySetCloning"
      },
      "rel": "contains",
      "target": "f334fbd1-ec31-4d71-beca-22741b63b3c7"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class PreventQuerySetCloning"
}
```
