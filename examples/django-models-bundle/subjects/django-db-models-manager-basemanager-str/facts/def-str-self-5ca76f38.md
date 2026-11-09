# Fact 5ca76f38

Store id: 555cbadd-3a64-49b7-8b30-84197f50f521

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:44:55.2546850+00:00`

## Data

```json
{
  "end_line": 37,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 35,
  "symbol": "BaseManager.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L37","symbol":"BaseManager.__str__"}`

## Items

```json
[
  {
    "text": "Return \"app_label.model_label.manager_name\".",
    "locator": {
      "line": 36
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 37,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 35,
    "symbol": "BaseManager.__str__"
  },
  "id": "555cbadd-3a64-49b7-8b30-84197f50f521",
  "items": [
    {
      "locator": {
        "line": 36
      },
      "text": "Return \"app_label.model_label.manager_name\"."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2546850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L37",
        "symbol": "BaseManager.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "8c11f475-0e99-45c8-877b-d15b6e28270f",
  "subject_name": "django/db/models/manager::BaseManager.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
