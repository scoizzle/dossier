# Fact c2fb955c

Store id: 224520d3-e23e-4a26-b8d4-1c5672e12e5b

## Text

```text
def _is_unset(value)
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
- posted_at: `2026-11-09T22:39:40.3361190+00:00`

## Data

```json
{
  "end_line": 718,
  "entity_kind": "function",
  "parent": "Model._is_pk_set",
  "start_line": 713,
  "symbol": "Model._is_pk_set._is_unset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":713,"selector":"L713-L718","symbol":"Model._is_pk_set._is_unset"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._is_pk_set._is_unset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 718,
    "entity_kind": "function",
    "parent": "Model._is_pk_set",
    "start_line": 713,
    "symbol": "Model._is_pk_set._is_unset"
  },
  "id": "224520d3-e23e-4a26-b8d4-1c5672e12e5b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3361190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 713,
        "selector": "L713-L718",
        "symbol": "Model._is_pk_set._is_unset"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "53022431-ad23-45b1-b803-921c1bfb9d86",
  "subject_name": "django/db/models/base::Model._is_pk_set._is_unset",
  "tags": [
    "entity:function"
  ],
  "text": "def _is_unset(value)"
}
```
