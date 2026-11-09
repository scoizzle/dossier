# Fact 15126800

Store id: df556ad2-7e39-4fb7-877d-301ee36984ec

## Text

```text
def unnest(fields)
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
- posted_at: `2026-11-09T23:31:57.1481390+00:00`

## Data

```json
{
  "end_line": 177,
  "entity_kind": "function",
  "parent": "composite",
  "start_line": 168,
  "symbol": "unnest"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"selector":"L168-L177","symbol":"unnest"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::unnest](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 177,
    "entity_kind": "function",
    "parent": "composite",
    "start_line": 168,
    "symbol": "unnest"
  },
  "id": "df556ad2-7e39-4fb7-877d-301ee36984ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.1481390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 168,
        "selector": "L168-L177",
        "symbol": "unnest"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "4d8ccf57-2293-4b4d-82a9-fb5f5fcae52f",
  "subject_name": "django/db/models/fields/composite::unnest",
  "tags": [
    "entity:function"
  ],
  "text": "def unnest(fields)"
}
```
