# Fact fa7e2cac

Store id: f4afccaf-e823-4ba4-883b-65414816895c

## Text

```text
def __reduce__(self)
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
- posted_at: `2026-11-09T23:44:48.5281500+00:00`

## Data

```json
{
  "end_line": 657,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 653,
  "symbol": "Model.__reduce__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":653,"selector":"L653-L657","symbol":"Model.__reduce__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__reduce__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 657,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 653,
    "symbol": "Model.__reduce__"
  },
  "id": "f4afccaf-e823-4ba4-883b-65414816895c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5281500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 653,
        "selector": "L653-L657",
        "symbol": "Model.__reduce__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "ab5f4208-87ee-402d-a869-3e9753d63f48",
  "subject_name": "django/db/models/base::Model.__reduce__",
  "tags": [
    "entity:method"
  ],
  "text": "def __reduce__(self)"
}
```
