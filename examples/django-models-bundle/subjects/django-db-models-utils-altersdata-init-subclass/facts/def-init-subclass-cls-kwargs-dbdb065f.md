# Fact dbdb065f

Store id: dbc7be5a-35ae-41a7-bcb3-c9a6819ae4f6

## Text

```text
def __init_subclass__(cls, **kwargs)
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
- posted_at: `2026-11-09T23:45:00.0697040+00:00`

## Data

```json
{
  "end_line": 69,
  "entity_kind": "method",
  "parent": "AltersData",
  "start_line": 60,
  "symbol": "AltersData.__init_subclass__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":60,"selector":"L60-L69","symbol":"AltersData.__init_subclass__"}`

## Referenced by

None.

## Subject

[django/db/models/utils::AltersData.__init_subclass__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 69,
    "entity_kind": "method",
    "parent": "AltersData",
    "start_line": 60,
    "symbol": "AltersData.__init_subclass__"
  },
  "id": "dbc7be5a-35ae-41a7-bcb3-c9a6819ae4f6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0697040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 60,
        "selector": "L60-L69",
        "symbol": "AltersData.__init_subclass__"
      },
      "rel": "derived_from",
      "target": "django/db/models/utils.py"
    }
  ],
  "status": "live",
  "subject_id": "c23bc138-5b1a-48ae-bfa7-e882616d0189",
  "subject_name": "django/db/models/utils::AltersData.__init_subclass__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init_subclass__(cls, **kwargs)"
}
```
