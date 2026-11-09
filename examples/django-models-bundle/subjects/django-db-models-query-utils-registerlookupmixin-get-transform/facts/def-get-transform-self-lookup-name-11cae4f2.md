# Fact 11cae4f2

Store id: 769e22cd-5f27-4a0f-8ea5-8dc655b64b4a

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
- posted_at: `2026-11-09T22:39:50.1504440+00:00`

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
  "id": "769e22cd-5f27-4a0f-8ea5-8dc655b64b4a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1504440+00:00"
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
  "subject_id": "d4aa3b12-97d8-4b10-a2fb-8c48c43e97f6",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, lookup_name)"
}
```
