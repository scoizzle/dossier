# Fact ae73c5ae

Store id: 8219eed0-0bc8-4b0d-9dd8-6b7e701a7c82

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
- posted_at: `2026-11-09T23:44:56.6859500+00:00`

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
  "id": "8219eed0-0bc8-4b0d-9dd8-6b7e701a7c82",
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
    "posted_at": "2026-11-09T23:44:56.6859500+00:00"
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
  "subject_id": "6e03934a-5908-4d6c-99e9-8eb294659bef",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin.merge_dicts",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def merge_dicts(dicts)"
}
```
