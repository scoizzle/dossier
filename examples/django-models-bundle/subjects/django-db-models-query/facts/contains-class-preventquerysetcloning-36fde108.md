# Fact 36fde108

Store id: 037489c5-3788-4a3d-b3dd-5faeadbfd16b

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
- posted_at: `2026-11-09T22:39:49.9155620+00:00`

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
  "id": "037489c5-3788-4a3d-b3dd-5faeadbfd16b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.9155620+00:00"
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
      "target": "5c8f7061-4cf0-477e-91a2-0126a021879b"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class PreventQuerySetCloning"
}
```
