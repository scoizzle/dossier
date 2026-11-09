# Fact 7aa6c4fe

Store id: ff84554a-31be-400a-a2a1-62019f2bf162

## Text

```text
def _clear_cached_class_lookups(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.1566330+00:00`

## Data

```json
{
  "end_line": 391,
  "entity_kind": "class_method",
  "parent": "RegisterLookupMixin",
  "start_line": 388,
  "symbol": "RegisterLookupMixin._clear_cached_class_lookups"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":388,"selector":"L388-L391","symbol":"RegisterLookupMixin._clear_cached_class_lookups"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::RegisterLookupMixin._clear_cached_class_lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 391,
    "entity_kind": "class_method",
    "parent": "RegisterLookupMixin",
    "start_line": 388,
    "symbol": "RegisterLookupMixin._clear_cached_class_lookups"
  },
  "id": "ff84554a-31be-400a-a2a1-62019f2bf162",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1566330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 388,
        "selector": "L388-L391",
        "symbol": "RegisterLookupMixin._clear_cached_class_lookups"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "a0199f3e-8977-4403-9e2b-a5519955c747",
  "subject_name": "django/db/models/query_utils::RegisterLookupMixin._clear_cached_class_lookups",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _clear_cached_class_lookups(cls)"
}
```
