# Fact 14a5bd05

Store id: 829909ad-6765-44bb-9a43-cc2393a7bbd1

## Text

```text
contains function resolve_callables
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.9512730+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/utils::resolve_callables](../../django-db-models-utils-resolve-callables/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":28,"symbol":"resolve_callables"}`

## Referenced by

None.

## Subject

[django/db/models/utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "829909ad-6765-44bb-9a43-cc2393a7bbd1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.9512730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 28,
        "symbol": "resolve_callables"
      },
      "rel": "contains",
      "target": "6e1057ee-cfbe-4ebc-8e57-e60501fac2ee"
    }
  ],
  "status": "live",
  "subject_id": "8d25c560-4eac-44c9-a77d-da20cef77164",
  "subject_name": "django/db/models/utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function resolve_callables"
}
```
