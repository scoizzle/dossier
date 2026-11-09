# Fact 0d1a9fcf

Store id: cd745e93-99eb-498a-81da-310e66218dfe

## Text

```text
def __or__(self, other)
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
- posted_at: `2026-11-09T23:32:05.0468200+00:00`

## Data

```json
{
  "end_line": 88,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 87,
  "symbol": "Q.__or__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":87,"selector":"L87-L88","symbol":"Q.__or__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__or__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 88,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 87,
    "symbol": "Q.__or__"
  },
  "id": "cd745e93-99eb-498a-81da-310e66218dfe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0468200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 87,
        "selector": "L87-L88",
        "symbol": "Q.__or__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "ffaf01f2-bb10-4312-abf8-c08d49df9edf",
  "subject_name": "django/db/models/query_utils::Q.__or__",
  "tags": [
    "entity:method"
  ],
  "text": "def __or__(self, other)"
}
```
