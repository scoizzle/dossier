# Fact c1716ad2

Store id: 768094e1-78a6-43b6-b646-71f06295f08c

## Text

```text
def get_parent_list(self)
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
- posted_at: `2026-11-09T23:44:55.5603160+00:00`

## Data

```json
{
  "end_line": 732,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 727,
  "symbol": "Options.get_parent_list"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":727,"selector":"L727-L732","symbol":"Options.get_parent_list"}`

## Items

```json
[
  {
    "text": "Return all the ancestors of this model as a list ordered by MRO. Backward compatibility method.",
    "locator": {
      "line": 728
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.get_parent_list](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 732,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 727,
    "symbol": "Options.get_parent_list"
  },
  "id": "768094e1-78a6-43b6-b646-71f06295f08c",
  "items": [
    {
      "locator": {
        "line": 728
      },
      "text": "Return all the ancestors of this model as a list ordered by MRO. Backward compatibility method."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5603160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 727,
        "selector": "L727-L732",
        "symbol": "Options.get_parent_list"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "2581c27b-05cc-4e75-bd71-9616fa99365d",
  "subject_name": "django/db/models/options::Options.get_parent_list",
  "tags": [
    "entity:method"
  ],
  "text": "def get_parent_list(self)"
}
```
