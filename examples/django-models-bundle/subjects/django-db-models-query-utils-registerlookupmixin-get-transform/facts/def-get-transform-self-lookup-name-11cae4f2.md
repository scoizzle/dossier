# Fact 11cae4f2

Store id: 5f12a5d5-1a00-4ddf-89d4-4a6ee6286477

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
- posted_at: `2026-11-09T23:32:05.1617160+00:00`

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
  "id": "5f12a5d5-1a00-4ddf-89d4-4a6ee6286477",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.1617160+00:00"
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
  "subject_id": "dfaedc80-2dd2-4edd-b960-4f24ab2947a8",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, lookup_name)"
}
```
