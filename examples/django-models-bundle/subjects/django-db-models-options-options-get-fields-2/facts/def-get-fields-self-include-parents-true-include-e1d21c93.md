# Fact e1d21c93

Store id: 3cd4556b-df96-4562-b302-c9f7904fe280

## Text

```text
def get_fields(self, include_parents=True, include_hidden=False)
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
- posted_at: `2026-11-09T22:39:48.9427460+00:00`

## Data

```json
{
  "end_line": 879,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 865,
  "symbol": "Options.get_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":865,"selector":"L865-L879","symbol":"Options.get_fields"}`

## Items

```json
[
  {
    "text": "Return a list of fields associated to the model. By default, include forward and reverse fields, fields derived from inheritance, but not hidden fields. The returned fields can be changed using the parameters:",
    "locator": {
      "line": 866
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.get_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 879,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 865,
    "symbol": "Options.get_fields"
  },
  "id": "3cd4556b-df96-4562-b302-c9f7904fe280",
  "items": [
    {
      "locator": {
        "line": 866
      },
      "text": "Return a list of fields associated to the model. By default, include forward and reverse fields, fields derived from inheritance, but not hidden fields. The returned fields can be changed using the parameters:"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.9427460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 865,
        "selector": "L865-L879",
        "symbol": "Options.get_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "b3b5682e-bc34-4a14-8591-f19ac20898f4",
  "subject_name": "django/db/models/options::Options.get_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_fields(self, include_parents=True, include_hidden=False)"
}
```
