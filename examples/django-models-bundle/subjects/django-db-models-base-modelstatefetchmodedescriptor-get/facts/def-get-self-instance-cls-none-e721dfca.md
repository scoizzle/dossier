# Fact e721dfca

Store id: 05f579c2-5f75-4338-ba8a-0f1d12fb0915

## Text

```text
def __get__(self, instance, cls=None)
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
- posted_at: `2026-11-09T22:39:40.3294410+00:00`

## Data

```json
{
  "end_line": 475,
  "entity_kind": "method",
  "parent": "ModelStateFetchModeDescriptor",
  "start_line": 471,
  "symbol": "ModelStateFetchModeDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":471,"selector":"L471-L475","symbol":"ModelStateFetchModeDescriptor.__get__"}`

## Referenced by

None.

## Subject

[django/db/models/base::ModelStateFetchModeDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 475,
    "entity_kind": "method",
    "parent": "ModelStateFetchModeDescriptor",
    "start_line": 471,
    "symbol": "ModelStateFetchModeDescriptor.__get__"
  },
  "id": "05f579c2-5f75-4338-ba8a-0f1d12fb0915",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3294410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 471,
        "selector": "L471-L475",
        "symbol": "ModelStateFetchModeDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "97d6eac5-fd9b-473a-aba9-6ef585a73ec3",
  "subject_name": "django/db/models/base::ModelStateFetchModeDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
