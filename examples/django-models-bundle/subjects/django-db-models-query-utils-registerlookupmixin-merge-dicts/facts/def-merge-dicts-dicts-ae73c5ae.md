# Fact ae73c5ae

Store id: c0fbc268-5b96-41e7-99a4-e7382b8c37c9

## Text

```text
def merge_dicts(dicts)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:static_method`, `decorator:staticmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.1533140+00:00`

## Data

```json
{
  "end_line": 386,
  "entity_kind": "static_method",
  "parent": "RegisterLookupMixin",
  "start_line": 376,
  "symbol": "RegisterLookupMixin.merge_dicts"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":376,"selector":"L376-L386","symbol":"RegisterLookupMixin.merge_dicts"}`

## Items

```json
[
  {
    "text": "Merge dicts in reverse to preference the order of the original list. e.g., merge_dicts([a, b]) will preference the keys in 'a' over those in 'b'.",
    "locator": {
      "line": 378
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin.merge_dicts](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 386,
    "entity_kind": "static_method",
    "parent": "RegisterLookupMixin",
    "start_line": 376,
    "symbol": "RegisterLookupMixin.merge_dicts"
  },
  "id": "c0fbc268-5b96-41e7-99a4-e7382b8c37c9",
  "items": [
    {
      "locator": {
        "line": 378
      },
      "text": "Merge dicts in reverse to preference the order of the original list. e.g., merge_dicts([a, b]) will preference the keys in 'a' over those in 'b'."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1533140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 376,
        "selector": "L376-L386",
        "symbol": "RegisterLookupMixin.merge_dicts"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "eb0f8271-cb8c-41fa-ac10-8bbe6af6f795",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.merge_dicts",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def merge_dicts(dicts)"
}
```
