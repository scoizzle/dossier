# Fact 11cae4f2

Store id: 98ffb083-7e82-4e33-8aea-2518e7bb6832

## Text

```text
def get_transform(self, lookup_name)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:56.6818200+00:00`

## Data

```json
{
  "end_line": 374,
  "entity_kind": "method",
  "parent": "RegisterLookupMixin",
  "start_line": 366,
  "symbol": "RegisterLookupMixin.get_transform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":366,"selector":"L366-L374","symbol":"RegisterLookupMixin.get_transform"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin.get_transform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 374,
    "entity_kind": "method",
    "parent": "RegisterLookupMixin",
    "start_line": 366,
    "symbol": "RegisterLookupMixin.get_transform"
  },
  "id": "98ffb083-7e82-4e33-8aea-2518e7bb6832",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.6818200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 366,
        "selector": "L366-L374",
        "symbol": "RegisterLookupMixin.get_transform"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "f3b4eced-583e-4975-a8a3-b94b86b0dd30",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, lookup_name)"
}
```
